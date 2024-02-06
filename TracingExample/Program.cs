// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");


TraceSource ts = new TraceSource("EtNavn");
ts.Switch = new SourceSwitch("Peters log", "All");


TraceListener consoleListener = new ConsoleTraceListener();
consoleListener.Filter = new EventTypeFilter(SourceLevels.Error);
ts.Listeners.Add(consoleListener);

TraceListener fileListener = new TextWriterTraceListener(
    new StreamWriter("TraceDemo.txt") { AutoFlush = true }); 
ts.Listeners.Add(fileListener);


TraceListener xmlListener = new XmlWriterTraceListener(
    new StreamWriter("TraceDemo.xml") { AutoFlush = true }
    );
ts.Listeners.Add(xmlListener);


TraceListener eventListener = new EventLogTraceListener("Application");
ts.Listeners.Add(eventListener);










ts.TraceEvent(TraceEventType.Information, 23, "Information");
ts.TraceEvent(TraceEventType.Warning, 23, "Warning");
ts.TraceEvent(TraceEventType.Error, 23, "Error");
ts.TraceEvent(TraceEventType.Critical, 23, "Critical");


consoleListener.Filter = new EventTypeFilter(SourceLevels.Information);
ts.TraceEvent(TraceEventType.Information, 23, "Information");
//ts.Flush();




