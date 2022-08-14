using System.Reflection;

[assembly: AssemblyTitle("assemblyinfo-update")]
/* Expected result:
[assembly: AssemblyDescription("Test file for use with the `assemblyinfo-update` Github action for updating versions in the format 0.0.0.0")]
*/
[assembly: AssemblyDescription("Test file for use with the `assemblyinfo-update` Github action for updating versions in the format 0.0.0.0")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Second Bounce Ltd")]
[assembly: AssemblyProduct("assemblyinfo-update")]
[assembly: AssemblyCopyright("Copyright © 2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: AssemblyVersion("1.11.*")]                 /* Expected result: "1.11.*" */
[assembly: AssemblyFileVersion("22.2.22.*")]          /* Expected result: "22.2.22.*" */
[assembly: AssemblyInformationalVersion("3.3.3.33")]  /* Expected result: "3.3.3.33" */
