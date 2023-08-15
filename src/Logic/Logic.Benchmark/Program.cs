using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

//BenchmarkRunner.Run<Logic.Benchmark.BinaryArrayConverterBenchmarks>();
//BenchmarkRunner.Run<Logic.Benchmark.ExponentialBackoffBenchmarks>();
//BenchmarkRunner.Run<Logic.Benchmark.Networks.CidrBlockBenchmarks>();
//BenchmarkRunner.Run<Logic.Benchmark.Networks.SubnetMaskBenchmarks>();
//BenchmarkRunner.Run<Logic.Benchmark.StopwatchBenchmarks>();
//BenchmarkRunner.Run<Logic.Benchmark.StringReverseBenchmarks>();
//BenchmarkRunner.Run<Logic.Benchmark.StringSplitBenchmarks>();
//BenchmarkRunner.Run<Logic.Benchmark.ValueTaskDelayBenchmarks>();
