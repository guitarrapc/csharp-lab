```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.37 ns** |  **1.779 ns** | **0.097 ns** |  **17.27 ns** |  **17.47 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 119.37 ns |  2.254 ns | 0.124 ns | 119.25 ns | 119.50 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 113.91 ns |  0.537 ns | 0.029 ns | 113.89 ns | 113.95 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  90.64 ns |  0.425 ns | 0.023 ns |  90.62 ns |  90.67 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.97 ns |  3.841 ns | 0.211 ns |  44.76 ns |  45.18 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.05 ns |  4.202 ns | 0.230 ns |  42.90 ns |  43.32 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 117.08 ns | 36.176 ns | 1.983 ns | 115.67 ns | 119.35 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.79 ns** | **13.447 ns** | **0.737 ns** |  **54.32 ns** |  **55.64 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 374.27 ns | 25.314 ns | 1.388 ns | 372.67 ns | 375.08 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 345.57 ns | 11.358 ns | 0.623 ns | 344.92 ns | 346.16 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 279.26 ns | 10.448 ns | 0.573 ns | 278.62 ns | 279.73 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.70 ns |  3.305 ns | 0.181 ns | 134.58 ns | 134.90 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.00 ns |  4.565 ns | 0.250 ns | 138.77 ns | 139.27 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 367.06 ns | 23.578 ns | 1.292 ns | 366.02 ns | 368.51 ns | 0.0057 |     504 B |
