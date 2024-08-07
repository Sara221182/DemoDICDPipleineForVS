namespace DemoProjectForGitHubCICDPipeline {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DemoProjectForGitHubCICDPipeline.Input1", typeof(global::DemoProjectForGitHubCICDPipeline.Input1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DemoProjectForGitHubCICDPipeline.Output1", typeof(global::DemoProjectForGitHubCICDPipeline.Output1))]
    public sealed class DemoMap1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://DemoProjectForGitHubCICDPipeline.Input1"" xmlns:ns0=""http://DemoProjectForGitHubCICDPipeline.Output1"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Root>
      <xsl:for-each select=""Record"">
        <xsl:variable name=""var:v1"" select=""userCSharp:MathMultiply(string(Test1/text()) , &quot;10&quot;)"" />
        <Record>
          <OutTest2>
            <xsl:value-of select=""$var:v1"" />
          </OutTest2>
        </Record>
      </xsl:for-each>
    </ns0:Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string MathMultiply(string param0, string param1)
{
	System.Collections.ArrayList listValues = new System.Collections.ArrayList();
	listValues.Add(param0);
	listValues.Add(param1);
	double ret = 1;
	bool first = true;
	foreach (string obj in listValues)
	{
		double d = 0;
		if (IsNumeric(obj, ref d))
		{
			if (first)
			{
				first = false;
				ret = d;
			}
			else
			{
				ret *= d;
			}
		}
		else
		{
			return """";
		}
	}
	return ret.ToString(System.Globalization.CultureInfo.InvariantCulture);
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
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
