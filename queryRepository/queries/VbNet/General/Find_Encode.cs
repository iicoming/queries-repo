CxList methods = Find_Methods();
result.Add(methods.FindByMemberAccess("AntiXss.HtmlAttributeEncode", false));
result.Add(methods.FindByMemberAccess("AntiXss.HtmlEncode", false));
result.Add(methods.FindByMemberAccess("AntiXss.JavaScriptEncode", false));
result.Add(methods.FindByMemberAccess("AntiXss.UrlEncode", false));
result.Add(methods.FindByMemberAccess("AntiXss.VisualBasicScriptEncode", false));
result.Add(methods.FindByMemberAccess("AntiXss.XmlAttributeEncode", false));
result.Add(methods.FindByMemberAccess("AntiXss.XmlEncode", false));
result.Add(methods.FindByMemberAccess("Encoder.CssEncode", false));
result.Add(methods.FindByMemberAccess("Encoder.HtmlAttributeEncode", false));
result.Add(methods.FindByMemberAccess("Encoder.HtmlEncode", false));
result.Add(methods.FindByMemberAccess("Encoder.HtmlFormUrlEncode", false));
result.Add(methods.FindByMemberAccess("Encoder.JavaScriptEncode", false));
result.Add(methods.FindByMemberAccess("Encoder.UrlEncode", false));
result.Add(methods.FindByMemberAccess("Encoder.UrlPathEncode", false));
result.Add(methods.FindByMemberAccess("Encoder.VisualBasicScriptEncode", false));
result.Add(methods.FindByMemberAccess("Encoder.XmlAttributeEncode", false));
result.Add(methods.FindByMemberAccess("Encoder.XmlEncode", false));
result.Add(methods.FindByMemberAccess("HttpUtility.UrlEncodeUnicode", false));
result.Add(methods.FindByMemberAccess("HttpUtility.UrlEncodeUnicodeToBytes", false));
result.Add(methods.FindByMemberAccess("Sanitizer.GetSafeHtml", false));
result.Add(methods.FindByMemberAccess("Sanitizer.GetSafeHtmlFragment", false));
result.Add(methods.FindByMemberAccess("SecurityElement.Escape", false));
result.Add(methods.FindByMemberAccess("WebUtility.HtmlEncode", false));
result.Add(methods.FindByMemberAccess("WebUtility.UrlEncode", false));
result.Add(methods.FindByMemberAccess("WebUtility.UrlEncodeToBytes", false));
result.Add(methods.FindByName("HttpContext.Current.Server.HtmlEncode", false));
result.Add(methods.FindByName("HttpContext.Current.Server.UrlEncode", false));
result.Add(methods.FindByMemberAccess("HttpServerUtility.UrlTokenEncode", false));
result.Add(methods.FindByMemberAccess("HttpUtility.HtmlEncode", false));
result.Add(methods.FindByMemberAccess("HttpUtility.UrlEncode", false));
result.Add(methods.FindByMemberAccess("HttpUtility.UrlEncodeToBytes", false));
result.Add(methods.FindByMemberAccess("AntiXssEncoder.CssEncode", false));
result.Add(methods.FindByMemberAccess("AntiXssEncoder.HtmlEncode", false));
result.Add(methods.FindByMemberAccess("AntiXssEncoder.HtmlFormUrlEncode", false));
result.Add(methods.FindByMemberAccess("AntiXssEncoder.UrlEncode", false));
result.Add(methods.FindByMemberAccess("AntiXssEncoder.XmlAttributesEncode", false));
result.Add(methods.FindByMemberAccess("AntiXssEncoder.XmlEncode", false));
result.Add(methods.FindByMemberAccess("Html.AttributeEncode", false));
result.Add(methods.FindByMemberAccess("Html.Encode", false));
result.Add(methods.FindByMemberAccess("Url.Encode", false));
result.Add(methods.FindByMemberAccess("Server.UrlEncode", false));
result.Add(methods.FindByMemberAccess("HttpServerUtility.UrlEncode", false));
result.Add(methods.FindByMemberAccess("HttpServerUtility.HtmlEncode", false));
result.Add(methods.FindByMemberAccess("HttpServerUtility.UrlTokenEncode", false));
result.Add(Find_HTML_Encode());