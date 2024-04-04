```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **18.31 ns** |   **0.364 ns** |  **0.020 ns** |  **18.30 ns** |  **18.33 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.11 ns |  15.775 ns |  0.865 ns | 122.23 ns | 123.96 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.98 ns |   8.523 ns |  0.467 ns | 118.45 ns | 119.29 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  92.84 ns |   3.562 ns |  0.195 ns |  92.65 ns |  93.04 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.73 ns |   2.363 ns |  0.130 ns |  45.63 ns |  45.88 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.08 ns |   2.747 ns |  0.151 ns |  44.98 ns |  45.25 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 124.42 ns |  15.595 ns |  0.855 ns | 123.80 ns | 125.39 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **57.27 ns** |   **4.820 ns** |  **0.264 ns** |  **57.00 ns** |  **57.53 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 394.54 ns |  20.823 ns |  1.141 ns | 393.28 ns | 395.52 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 352.25 ns |  16.130 ns |  0.884 ns | 351.29 ns | 353.03 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 290.56 ns |  27.126 ns |  1.487 ns | 289.38 ns | 292.23 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 137.24 ns |   2.983 ns |  0.164 ns | 137.11 ns | 137.42 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.41 ns |  16.493 ns |  0.904 ns | 136.86 ns | 138.45 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 382.11 ns | 215.967 ns | 11.838 ns | 371.19 ns | 394.69 ns | 0.0057 |     504 B |
