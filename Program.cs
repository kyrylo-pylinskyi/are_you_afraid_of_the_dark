using AreYouAfraidOfTheDark;
using Microsoft.Extensions.Configuration;

IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddCommandLine(args)
    .Build();

var imgProcessor = new ImageProcessor(configuration);

imgProcessor.ProcessImagesParallel();