// See https://aka.ms/new-console-template for more information
using builder_pattern.Concrete;

Console.WriteLine("Hello, World!");

var watchBuilder = new WatchBuilder();
watchBuilder.BuildWatchType();
watchBuilder.BuildWatchSize();
watchBuilder.BuildWatchColor();

var strapBuilder = new StrapBuilder(watchBuilder.GetWatch());

strapBuilder.BuildStrapType();
strapBuilder.BuildStrapSize();
strapBuilder.BuildWatchStrapColor();

Console.Write(strapBuilder.GetWatch().GetWatchSummary());