```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,231.6 ns** |     **19.79 ns** |     **1.08 ns** |     **1,230.6 ns** |     **1,232.7 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,359.6 ns |     49.83 ns |     2.73 ns |     1,357.7 ns |     1,362.7 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,606.1 ns |    100.03 ns |     5.48 ns |     1,599.8 ns |     1,609.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,574.6 ns |    162.20 ns |     8.89 ns |     2,564.4 ns |     2,580.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       209.0 ns |     21.06 ns |     1.15 ns |       207.9 ns |       210.2 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       285.6 ns |     34.31 ns |     1.88 ns |       284.4 ns |       287.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       494.7 ns |     41.78 ns |     2.29 ns |       492.7 ns |       497.2 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,989.4 ns** | **12,877.91 ns** |   **705.88 ns** | **1,554,286.9 ns** | **1,555,698.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,837.0 ns |  2,640.21 ns |   144.72 ns |   617,698.7 ns |   617,987.4 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   660,623.1 ns | 25,575.02 ns | 1,401.85 ns |   659,033.6 ns |   661,682.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,382,877.3 ns | 44,517.03 ns | 2,440.13 ns | 1,380,087.8 ns | 1,384,615.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,886.4 ns | 22,234.18 ns | 1,218.73 ns |   163,035.2 ns |   165,282.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,025.8 ns |  2,823.94 ns |   154.79 ns |    91,897.1 ns |    92,197.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,992.2 ns |  4,807.42 ns |   263.51 ns |    65,695.5 ns |    66,199.2 ns |      - |      40 B |
