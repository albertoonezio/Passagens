﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "SearchCliente/{nome}")]
        Cliente Buscar(string nome);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "addCliente/{nome};{cpf}")]
        void Add(string nome, string cpf);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "getClientes/")]
        List<Cliente> GetClientes();
    }
}
