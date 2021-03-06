﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Org.Reddragonit.VueJSMVCDotNet.Interfaces
{
    internal interface IRequestHandler
    {
        void Init(List<Type> types);
        void ClearCache();
        bool HandlesRequest(string url, RequestHandler.RequestMethods method);
        Task HandleRequest(string url, RequestHandler.RequestMethods method, string formData, HttpContext context,ISecureSession session, IsValidCall securityCheck);
    }
}
