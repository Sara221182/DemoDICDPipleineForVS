namespace DemoProjectForGitHubCICDPipeline {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DemoProjectForGitHubCICDPipeline.Input1", typeof(global::DemoProjectForGitHubCICDPipeline.Input1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DemoProjectForGitHubCICDPipeline.Output1", typeof(global::DemoProjectForGitHubCICDPipeline.Output1))]
    public sealed class DemoMap1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://DemoProjectForGitHubCICDPipeline.Input1"" xmlns:ns0=""http://DemoProjectForGitHubCICDPipeline.Output1"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Root>
      <xsl:for-each select=""Record"">
        <Record>
          <OutTest2>
            <xsl:value-of select=""Test1/text()"" />
          </OutTest2>
        </Record>
      </xsl:for-each>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DemoProjectForGitHubCICDPipeline.Input1";
        
        private const global::DemoProjectForGitHubCICDPipeline.Input1 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DemoProjectForGitHubCICDPipeline.Output1";
        
        private const global::DemoProjectForGitHubCICDPipeline.Output1 _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DemoProjectForGitHubCICDPipeline.Input1";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DemoProjectForGitHubCICDPipeline.Output1";
                return _TrgSchemas;
            }
        }
    }
}
