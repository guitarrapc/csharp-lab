```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.40 ns** |   **0.455 ns** | **0.025 ns** |  **17.38 ns** |  **17.43 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.34 ns |   5.421 ns | 0.297 ns | 121.06 ns | 121.65 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.47 ns |   7.696 ns | 0.422 ns | 118.18 ns | 118.95 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.26 ns |   9.572 ns | 0.525 ns |  90.81 ns |  91.84 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.51 ns |  20.567 ns | 1.127 ns |  44.84 ns |  46.82 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.45 ns |  17.100 ns | 0.937 ns |  43.64 ns |  45.48 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 124.17 ns |  18.973 ns | 1.040 ns | 123.13 ns | 125.21 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.51 ns** |   **1.593 ns** | **0.087 ns** |  **54.41 ns** |  **54.56 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 394.37 ns |   1.821 ns | 0.100 ns | 394.31 ns | 394.48 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 358.84 ns | 118.339 ns | 6.487 ns | 355.09 ns | 366.33 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 276.99 ns |  11.871 ns | 0.651 ns | 276.28 ns | 277.55 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.36 ns |   2.627 ns | 0.144 ns | 134.23 ns | 134.52 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.09 ns |   5.226 ns | 0.286 ns | 135.81 ns | 136.39 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 363.50 ns |  13.415 ns | 0.735 ns | 362.85 ns | 364.29 ns | 0.0057 |     504 B |
