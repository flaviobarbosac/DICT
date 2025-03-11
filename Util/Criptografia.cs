using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;

namespace IvyPay.PI.Dict.Domain.Util
{
    public static class CriptografiaAssimetrica
    {
        /// <summary>
        /// Método exposto para Criptografar
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objeto"></param>
        /// <param name="chavePublica"></param>
        /// <returns></returns>
        public static string Criptografar<T>(this T objeto, string chavePublica)
        {
            if (objeto == null)
            {
                throw new ArgumentNullException(nameof(objeto), "O objeto não pode ser nulo.");
            }

            string mensagem = Convert.ToString(objeto) ?? string.Empty;
            return CriptografiaAssimetrica.Encriptar(chavePublica, mensagem);
        }

        /// <summary>
        /// Método exposto para Descriptografar
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objeto"></param>
        /// <param name="chavePrivada"></param>
        /// <returns></returns>
        public static string Descriptografar<T>(this T objeto, string chavePrivada)
        {
            string mensagem = Convert.ToString(objeto) ?? string.Empty;
            return CriptografiaAssimetrica.Decriptar(chavePrivada, mensagem);
        }

        /// <summary>
        /// Gera par de chaves.
        /// </summary>
        /// <param name="enderecoDaChavePublica">Endereco onde deve salvar a chave publica</param>
        /// <returns>Chave privada.</returns>
        public static Tuple<byte[], byte[]> ObterChaves()
        {
            var parametros = new RsaKeyGenerationParameters(new Org.BouncyCastle.Math.BigInteger("65537"), new SecureRandom(), 2048, 25);
            var geradorDeChaves = new RsaKeyPairGenerator();
            MemoryStream streamDeMemoria = new MemoryStream();
            TextWriter geradorDeConteudo = new StreamWriter(streamDeMemoria);

            geradorDeChaves.Init(parametros);
            var chaves = geradorDeChaves.GenerateKeyPair();

            PemWriter geradorDePem = new PemWriter(geradorDeConteudo);

            geradorDePem.WriteObject(chaves.Public);
            geradorDePem.Writer.Flush();
            streamDeMemoria.Flush();

            byte[] chavePublica = streamDeMemoria.ToArray();

            geradorDePem.Writer.Close();
            streamDeMemoria.Close();

            streamDeMemoria = new MemoryStream();
            geradorDeConteudo = new StreamWriter(streamDeMemoria);
            geradorDePem = new PemWriter(geradorDeConteudo);

            geradorDePem.WriteObject(chaves.Private);
            geradorDePem.Writer.Flush();
            streamDeMemoria.Flush();

            byte[] chavePrivada = streamDeMemoria.ToArray();

            geradorDePem.Writer.Close();
            streamDeMemoria.Close();

            return new Tuple<byte[], byte[]>(chavePublica, chavePrivada);
        }

        private static string Decriptar(string chavePrivada, string mensagem)
        {
            string retorno = "";

            try
            {
                PemReader readerCert = new PemReader(new StringReader(chavePrivada));
                AsymmetricCipherKeyPair keys = (AsymmetricCipherKeyPair)readerCert.ReadObject();

                // metodo generico uso mobile

                Console.WriteLine("INICIO - criptografia antiga");
                var mensagemFormatada = Convert.FromBase64String(mensagem);
                var motorDeCriptografia = new RsaEngine();
                motorDeCriptografia.Init(true, keys.Private);

                int tamanhoDaMensagem = mensagemFormatada.Length;
                int tamanhoDoBloco = motorDeCriptografia.GetInputBlockSize() + 1;
                List<byte> mensagemDecifrada = new List<byte>();

                for (int i = 0; i < tamanhoDaMensagem; i += tamanhoDoBloco)
                {
                    int tamanhoDoBlocoDaMensagem = Math.Min(tamanhoDoBloco, tamanhoDaMensagem - i);
                    mensagemDecifrada.AddRange(motorDeCriptografia.ProcessBlock(mensagemFormatada, i, tamanhoDoBlocoDaMensagem));
                }

                mensagemDecifrada.RemoveAll(x => x == 0);


                //se nao encontrar um caractere utf na conversão substitui ele por um texto
                Encoding enc = Encoding.GetEncoding("UTF-8",
                                      new EncoderReplacementFallback("X;]4tZ<pERRORXS+%~^3U"),
                                      new DecoderReplacementFallback("X;]4tZ<pERRORXS+%~^3U"));

                retorno = enc.GetString(mensagemDecifrada.ToArray());

                Console.WriteLine("FIM - criptografia antiga");

                if (retorno.Contains("ERROR"))
                {

                    Console.WriteLine("INICIO - criptografia nova");

                    // metodo generico uso mobile IOS

                    RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider();


                    Func<RSACryptoServiceProvider, RsaPrivateCrtKeyParameters, RSACryptoServiceProvider> MakePrivateRCSP = (RSACryptoServiceProvider rcsp, RsaPrivateCrtKeyParameters rkp) =>
                    {
                        RSAParameters rsaParameters = DotNetUtilities.ToRSAParameters(rkp);
                        rcsp.ImportParameters(rsaParameters);
                        return rsaKey;
                    };


                    var cipher = MakePrivateRCSP(rsaKey, (RsaPrivateCrtKeyParameters)(keys.Private));


                    byte[] original = cipher.Decrypt(Convert.FromBase64String(mensagem), false);

                    retorno = Encoding.UTF8.GetString(original);


                    Console.WriteLine("FIM - criptografia nova");


                    return retorno;

                }
                else
                {

                    return retorno = enc.GetString(mensagemDecifrada.ToArray());
                }
            }
            catch (Exception ex)
            {
                retorno = ex.Message;
            }

            return retorno;

        }
        private static string Encriptar(string chavePublica, string mensagem)
        {
            PemReader reader = new PemReader(new StringReader(chavePublica));
            AsymmetricKeyParameter chave = (AsymmetricKeyParameter)reader.ReadObject();

            var bytesToEncrypt = Encoding.UTF8.GetBytes(mensagem);
            var encryptEngine = new RsaEngine();
            encryptEngine.Init(true, chave);

            int lengthEncrypt = bytesToEncrypt.Length;
            int blockSizeEncrypt = encryptEngine.GetInputBlockSize() + 1;
            List<byte> cipherTextBytes = new List<byte>();

            for (int chunkPosition = 0;
                chunkPosition < lengthEncrypt;
                chunkPosition += blockSizeEncrypt)
            {
                int chunkSize = Math.Min(blockSizeEncrypt, lengthEncrypt - chunkPosition);
                cipherTextBytes.AddRange(encryptEngine.ProcessBlock(
                    bytesToEncrypt, chunkPosition, chunkSize
                ));
            }

            return Convert.ToBase64String(cipherTextBytes.ToArray());
        }

        private static string EncriptarMobile(string chavePublica, string mensagem)
        {
            // metodo generico uso mobile

            RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider();

            Func<RSACryptoServiceProvider, RsaKeyParameters, RSACryptoServiceProvider> MakePublicRCSP = (RSACryptoServiceProvider rcsp, RsaKeyParameters rkp) =>
            {
                RSAParameters rsaParameters = DotNetUtilities.ToRSAParameters(rkp);
                rcsp.ImportParameters(rsaParameters);
                return rsaKey;
            };

            PemReader reader = new PemReader(new StringReader(chavePublica));
            object kp = reader.ReadObject();


            byte[] plainTextData = Encoding.UTF8.GetBytes(mensagem);

            var cipher = MakePublicRCSP(rsaKey, (RsaKeyParameters)kp);

            byte[] original = cipher.Encrypt(plainTextData, false);


            return Convert.ToBase64String(original.ToArray());
        }
    }
}