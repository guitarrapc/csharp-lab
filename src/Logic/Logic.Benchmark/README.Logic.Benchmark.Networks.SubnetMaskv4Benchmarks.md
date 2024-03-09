```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.07 ns** |  **0.730 ns** | **0.040 ns** |  **17.03 ns** |  **17.10 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.99 ns | 40.986 ns | 2.247 ns | 119.54 ns | 123.57 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.86 ns |  0.865 ns | 0.047 ns | 116.81 ns | 116.90 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  90.36 ns |  4.678 ns | 0.256 ns |  90.07 ns |  90.57 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.44 ns |  4.619 ns | 0.253 ns |  44.17 ns |  44.67 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.57 ns | 14.019 ns | 0.768 ns |  43.01 ns |  44.44 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 122.93 ns | 10.620 ns | 0.582 ns | 122.43 ns | 123.57 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.29 ns** |  **2.419 ns** | **0.133 ns** |  **54.17 ns** |  **54.43 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 374.38 ns | 16.265 ns | 0.892 ns | 373.54 ns | 375.32 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 357.41 ns |  4.400 ns | 0.241 ns | 357.15 ns | 357.62 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 277.72 ns | 11.022 ns | 0.604 ns | 277.15 ns | 278.36 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 133.15 ns | 13.017 ns | 0.714 ns | 132.62 ns | 133.96 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 135.33 ns |  2.512 ns | 0.138 ns | 135.17 ns | 135.42 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 366.43 ns | 58.049 ns | 3.182 ns | 364.02 ns | 370.04 ns | 0.0057 |     504 B |
