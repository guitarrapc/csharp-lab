using BenchmarkDotNet.Running;
using LoggerBenchmark;

var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

// BenchmarkRunner.Run<LoggerBenchmarks>();
