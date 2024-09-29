```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **18.47 ns** |   **0.815 ns** | **0.045 ns** |  **18.43 ns** |  **18.52 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 119.17 ns |  17.170 ns | 0.941 ns | 118.61 ns | 120.25 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.56 ns |  28.749 ns | 1.576 ns | 115.00 ns | 118.15 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.82 ns |  21.432 ns | 1.175 ns |  89.67 ns |  92.02 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.15 ns |  12.379 ns | 0.679 ns |  43.41 ns |  44.75 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.12 ns |   9.625 ns | 0.528 ns |  43.79 ns |  44.73 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.02 ns |  16.776 ns | 0.920 ns | 117.17 ns | 119.00 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **53.75 ns** |   **9.438 ns** | **0.517 ns** |  **53.41 ns** |  **54.34 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 371.96 ns |  53.790 ns | 2.948 ns | 368.83 ns | 374.68 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 350.01 ns |  68.023 ns | 3.729 ns | 345.89 ns | 353.15 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 279.02 ns |  23.179 ns | 1.271 ns | 278.04 ns | 280.46 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.12 ns |  21.957 ns | 1.204 ns | 132.82 ns | 135.19 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 134.29 ns |   4.172 ns | 0.229 ns | 134.03 ns | 134.45 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 367.81 ns | 120.505 ns | 6.605 ns | 361.29 ns | 374.50 ns | 0.0057 |     504 B |
