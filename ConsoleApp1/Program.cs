using ConsoleApp1;
using ConsoleApp1.EasyReport;
using ConsoleApp1.ExtendedReport;

var easyReport = new EasyReport()
{
    Meta = new EasyMeta()
    {
        Creator = "Starinin Andrey"
    },
    Header = new EasyHeader()
    {
        Title = "Easy report"
    },
    Body = new EasyBody()
    {
        Sections = new List<string>() {"One", "Two"}
    },
    Footer = new EasyFooter()
};

PrintReport.ToConsole(easyReport);

var extReport = new ExtendedReport
{
    Meta = new ExtendedMeta
    {
        Creator = "Starinin Andrey",
        Description = "test"
    },
    Header = new ExtendedHeader
    {
        Title = "Easy report",
        User = "Starinin Andrey"
    },
    Body = new ExtendedBody
    {
        Sections = new List<string>()
        {
            "One",
            "Two"
        },
        Total = "null"
    },
    Footer = new ExtendedFooter
    {
        Page = ""
    },
    TotalPages = 0
};
PrintReport.ToConsole(extReport);

PrintReport.ToJson(extReport, out var jsonExtReport);
File.WriteAllText("ext_report.json", jsonExtReport);

PrintReport.ToJson(easyReport, out var jsonEasyReport);
File.WriteAllText("easy_report.json", jsonEasyReport);