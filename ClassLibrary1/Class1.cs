using System;
using System.Collections.Generic; 
using System.Text; 
using System.Management.Automation;

namespace ClassLibrary1
{
    [Cmdlet(VerbsCommon.Get,"Salutaion")]
    public class GetSalutation :PSCmdlet
    {
        private string[] nameCollection;
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Position = 0, HelpMessage = "Name")]
        [Alias("Person", "FirstName")]
        public string[] Name
        {
            get { return nameCollection; }
            set { nameCollection = value; }
        }

        protected override void ProcessRecord()
        {
            foreach (string name in nameCollection)
            {
                WriteVerbose("Creating Salutation for " + name);
                string salutation = "Hello, " + name;
                WriteObject(salutation);
            }
        }
    }
}
