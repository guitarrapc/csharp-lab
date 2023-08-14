using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

//BenchmarkRunner.Run<LogicLab.Benchmark.BinaryArrayConverterBenchmarks>();
//BenchmarkRunner.Run<LogicLab.Benchmark.ExponentialBackoffBenchmarks>();
//BenchmarkRunner.Run<LogicLab.Benchmark.StopwatchBenchmarks>();
//BenchmarkRunner.Run<LogicLab.Benchmark.StringReverseBenchmarks>();
//BenchmarkRunner.Run<LogicLab.Benchmark.StringSplitBenchmarks>();
//BenchmarkRunner.Run<LogicLab.Benchmark.ValueTaskDelayBenchmarks>();
//BenchmarkRunner.Run<LogicLab.Benchmark.Networks.CidrBlockBenchmarks>();
//BenchmarkRunner.Run<LogicLab.Benchmark.Networks.SubnetMaskBenchmarks>();
