```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.67 ns** |  **1.781 ns** | **0.098 ns** |  **17.56 ns** |  **17.73 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 125.17 ns | 15.333 ns | 0.840 ns | 124.39 ns | 126.06 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.70 ns |  9.324 ns | 0.511 ns | 116.20 ns | 117.22 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.88 ns |  7.101 ns | 0.389 ns |  91.63 ns |  92.33 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  46.35 ns |  1.224 ns | 0.067 ns |  46.30 ns |  46.43 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.66 ns |  1.013 ns | 0.056 ns |  43.62 ns |  43.72 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.50 ns | 38.478 ns | 2.109 ns | 117.35 ns | 121.57 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **58.18 ns** |  **4.410 ns** | **0.242 ns** |  **57.90 ns** |  **58.35 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 368.53 ns | 13.062 ns | 0.716 ns | 367.91 ns | 369.31 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 350.38 ns | 28.170 ns | 1.544 ns | 349.47 ns | 352.16 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 280.35 ns |  8.810 ns | 0.483 ns | 279.84 ns | 280.80 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.59 ns |  5.003 ns | 0.274 ns | 135.29 ns | 135.83 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.96 ns | 10.394 ns | 0.570 ns | 139.35 ns | 140.47 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 377.25 ns | 22.295 ns | 1.222 ns | 376.02 ns | 378.46 ns | 0.0057 |     504 B |
