using BenchmarkDotNet.Running;

_ = BenchmarkRunner.Run(typeof(Program).Assembly);

// BenchmarkRunner.Run<LoggerBenchmarks>();
