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
| **FromPrefix**          | **1**      |  **17.65 ns** |  **5.541 ns** | **0.304 ns** |  **17.43 ns** |  **18.00 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.40 ns |  2.954 ns | 0.162 ns | 120.29 ns | 120.58 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.93 ns |  4.142 ns | 0.227 ns | 116.67 ns | 117.08 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  93.56 ns |  2.660 ns | 0.146 ns |  93.45 ns |  93.73 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.30 ns |  1.481 ns | 0.081 ns |  45.22 ns |  45.38 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.10 ns | 19.513 ns | 1.070 ns |  44.43 ns |  46.33 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 124.24 ns | 11.160 ns | 0.612 ns | 123.64 ns | 124.87 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.70 ns** |  **2.788 ns** | **0.153 ns** |  **54.54 ns** |  **54.85 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 367.02 ns |  1.890 ns | 0.104 ns | 366.90 ns | 367.09 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 362.05 ns | 61.796 ns | 3.387 ns | 359.97 ns | 365.96 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 286.27 ns | 13.204 ns | 0.724 ns | 285.85 ns | 287.10 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.54 ns | 19.528 ns | 1.070 ns | 134.75 ns | 136.76 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.19 ns |  0.722 ns | 0.040 ns | 140.15 ns | 140.22 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 366.78 ns | 15.554 ns | 0.853 ns | 366.13 ns | 367.74 ns | 0.0057 |     504 B |
