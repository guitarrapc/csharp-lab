using BenchmarkDotNet.Running;
using Logic.Benchmark;

var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

//BenchmarkRunner.Run<BinaryArrayConverterBenchmarks>();
//BenchmarkRunner.Run<ExponentialBackoffBenchmarks>();
//BenchmarkRunner.Run<StopwatchBenchmarks>();
//BenchmarkRunner.Run<StringReverseBenchmarks>();
//BenchmarkRunner.Run<StringSplitBenchmarks>();
//BenchmarkRunner.Run<ValueTaskDelayBenchmarks>();
