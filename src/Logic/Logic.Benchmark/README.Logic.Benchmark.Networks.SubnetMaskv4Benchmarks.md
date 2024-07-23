```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.56 ns** |  **1.664 ns** | **0.091 ns** |  **17.46 ns** |  **17.63 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 119.90 ns |  8.249 ns | 0.452 ns | 119.41 ns | 120.30 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.96 ns |  7.305 ns | 0.400 ns | 118.54 ns | 119.33 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.36 ns |  4.089 ns | 0.224 ns |  90.18 ns |  90.61 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.18 ns |  1.228 ns | 0.067 ns |  45.12 ns |  45.25 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.16 ns | 11.552 ns | 0.633 ns |  44.48 ns |  45.74 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 123.30 ns | 61.901 ns | 3.393 ns | 119.69 ns | 126.42 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.61 ns** |  **5.845 ns** | **0.320 ns** |  **55.31 ns** |  **55.95 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 367.65 ns | 25.794 ns | 1.414 ns | 366.11 ns | 368.89 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 358.50 ns | 19.944 ns | 1.093 ns | 357.40 ns | 359.59 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 276.94 ns | 16.889 ns | 0.926 ns | 275.99 ns | 277.84 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.78 ns |  5.628 ns | 0.308 ns | 134.47 ns | 135.08 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.95 ns | 19.125 ns | 1.048 ns | 140.32 ns | 142.16 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 366.48 ns | 11.920 ns | 0.653 ns | 365.78 ns | 367.07 ns | 0.0057 |     504 B |
