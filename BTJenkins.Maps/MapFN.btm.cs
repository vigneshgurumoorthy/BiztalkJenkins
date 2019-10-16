namespace BTJenkins.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTJenkins.Schemas.Input", typeof(global::BTJenkins.Schemas.Input))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTJenkins.Schemas.Output", typeof(global::BTJenkins.Schemas.Output))]
    public sealed class MapFN : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://BTJenkins.Schemas.Input"" xmlns:ns0=""http://BTJenkins.Schemas.Output"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Request"" />
  </xsl:template>
  <xsl:template match=""/s0:Request"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(FN/text()) , string(LN/text()))"" />
    <ns0:Res>
      <FullName>
        <xsl:value-of select=""$var:v1"" />
      </FullName>
    </ns0:Res>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BTJenkins.Schemas.Input";
        
        private const global::BTJenkins.Schemas.Input _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BTJenkins.Schemas.Output";
        
        private const global::BTJenkins.Schemas.Output _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BTJenkins.Schemas.Input";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BTJenkins.Schemas.Output";
                return _TrgSchemas;
            }
        }
    }
}
