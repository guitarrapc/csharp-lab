using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

// BenchmarkRunner.Run<LoggerBenchmarks>();
