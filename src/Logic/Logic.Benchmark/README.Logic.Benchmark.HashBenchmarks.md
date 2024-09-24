```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,242.0 ns** |     **164.41 ns** |     **9.01 ns** |     **1,234.7 ns** |     **1,252.0 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,375.6 ns |      83.49 ns |     4.58 ns |     1,370.7 ns |     1,379.8 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,615.8 ns |      27.42 ns |     1.50 ns |     1,614.2 ns |     1,617.2 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,612.8 ns |     108.66 ns |     5.96 ns |     2,606.7 ns |     2,618.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       206.1 ns |       5.07 ns |     0.28 ns |       205.9 ns |       206.4 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       293.4 ns |      19.59 ns |     1.07 ns |       292.5 ns |       294.6 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       492.8 ns |      37.57 ns |     2.06 ns |       490.9 ns |       495.0 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,211.6 ns** |  **10,349.86 ns** |   **567.31 ns** | **1,553,648.9 ns** | **1,554,783.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,546.2 ns |   2,996.24 ns |   164.23 ns |   617,359.7 ns |   617,669.1 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,897.3 ns |  25,918.82 ns | 1,420.70 ns |   658,296.4 ns |   661,007.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,384,934.4 ns | 114,556.83 ns | 6,279.25 ns | 1,380,649.6 ns | 1,392,142.3 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,515.1 ns |   9,311.13 ns |   510.37 ns |   163,162.9 ns |   164,100.4 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,208.7 ns |   2,441.90 ns |   133.85 ns |    92,095.2 ns |    92,356.3 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,948.7 ns |   6,824.68 ns |   374.08 ns |    65,658.5 ns |    66,370.9 ns |      - |      40 B |
