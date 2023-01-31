using System;
using System.Collections.Specialized;
using System.Configuration;

namespace Comunicacao.Messagem
{
    public static class ConfiguracaoAppSettings
    {
        private static System.Collections.Specialized.NameValueCollection configuracaoAplicacao = ConfigurationManager
                                    .GetSection("ApplicationSettings")  as NameValueCollection;

        public static string GetValueKey(string chave)
        {
            foreach (var key in configuracaoAplicacao.AllKeys)
            {
                if(key.Equals(chave))
                    return configuracaoAplicacao[key];
            }

            throw new Exception("A seção ConfiguracaoAplicacao não esta definida");
        }
    }
}