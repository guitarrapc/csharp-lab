```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **25.55 ns** |  **5.413 ns** | **0.297 ns** |  **25.21 ns** |  **25.75 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 116.71 ns |  5.792 ns | 0.317 ns | 116.35 ns | 116.90 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 112.59 ns |  7.975 ns | 0.437 ns | 112.30 ns | 113.09 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  80.87 ns |  7.944 ns | 0.435 ns |  80.37 ns |  81.14 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  42.17 ns |  3.617 ns | 0.198 ns |  41.95 ns |  42.33 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  39.29 ns |  3.494 ns | 0.192 ns |  39.11 ns |  39.49 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 116.84 ns | 13.000 ns | 0.713 ns | 116.27 ns | 117.64 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **76.04 ns** |  **4.966 ns** | **0.272 ns** |  **75.73 ns** |  **76.23 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 357.73 ns | 16.815 ns | 0.922 ns | 356.91 ns | 358.73 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 334.33 ns | 18.097 ns | 0.992 ns | 333.52 ns | 335.44 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 248.80 ns |  9.983 ns | 0.547 ns | 248.38 ns | 249.42 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 123.41 ns | 18.899 ns | 1.036 ns | 122.80 ns | 124.61 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 117.10 ns | 30.677 ns | 1.682 ns | 116.10 ns | 119.04 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 358.58 ns | 16.602 ns | 0.910 ns | 357.96 ns | 359.63 ns | 0.0300 |     504 B |
