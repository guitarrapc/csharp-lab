```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,481.8 ns** |  **4,121.33 ns** |   **225.90 ns** |     **1,350.0 ns** |     **1,742.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,457.7 ns |     40.77 ns |     2.23 ns |     1,455.1 ns |     1,459.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,688.7 ns |     62.58 ns |     3.43 ns |     1,685.9 ns |     1,692.5 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,634.8 ns |     30.52 ns |     1.67 ns |     2,633.4 ns |     2,636.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       199.3 ns |     24.27 ns |     1.33 ns |       198.3 ns |       200.9 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.3 ns |     18.27 ns |     1.00 ns |       285.2 ns |       287.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       494.8 ns |     21.10 ns |     1.16 ns |       493.8 ns |       496.1 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,819.6 ns** |  **2,296.43 ns** |   **125.88 ns** | **1,545,700.2 ns** | **1,545,951.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,346.0 ns |  2,140.89 ns |   117.35 ns |   614,234.8 ns |   614,468.7 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,246.4 ns | 23,954.87 ns | 1,313.05 ns |   654,870.5 ns |   657,485.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,428.0 ns | 13,925.83 ns |   763.32 ns | 1,372,947.7 ns | 1,374,308.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,692.4 ns | 12,329.81 ns |   675.84 ns |   162,239.4 ns |   163,469.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,420.5 ns |  1,194.24 ns |    65.46 ns |    91,358.2 ns |    91,488.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,396.8 ns |  2,207.31 ns |   120.99 ns |    65,270.4 ns |    65,511.5 ns |      - |      40 B |
