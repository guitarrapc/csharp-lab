using BenchmarkDotNet.Running;

BenchmarkRunner.Run(typeof(Program).Assembly);

//BenchmarkRunner.Run<Logic.Benchmark.BinaryArrayConverterBenchmarks>();
//BenchmarkRunner.Run<Logic.Benchmark.ExponentialBackoffBenchmarks>();
//BenchmarkRunner.Run<Logic.Benchmark.GuidMergeBenchmarks>();
//BenchmarkRunner.Run<Logic.Benchmark.HashBenchmarks>();
//BenchmarkRunner.Run<Logic.Benchmark.Networks.CidrBlockv4Benchmarks>();
//BenchmarkRunner.Run<Logic.Benchmark.Networks.CidrSubnetBenchmarks>();
//BenchmarkRunner.Run<Logic.Benchmark.Networks.SubnetMaskv4Benchmarks>();
//BenchmarkRunner.Run<Logic.Benchmark.ValueStopwatchBenchmarks>();
//BenchmarkRunner.Run<Logic.Benchmark.ValueTaskDelayBenchmarks>();
