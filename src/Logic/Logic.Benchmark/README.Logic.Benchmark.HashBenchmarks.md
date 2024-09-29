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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,225.4 ns** |    **126.40 ns** |     **6.93 ns** |     **1,220.9 ns** |     **1,233.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,359.6 ns |    112.17 ns |     6.15 ns |     1,352.5 ns |     1,363.7 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,590.6 ns |    168.16 ns |     9.22 ns |     1,583.7 ns |     1,601.1 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,559.8 ns |     97.40 ns |     5.34 ns |     2,554.1 ns |     2,564.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       197.2 ns |     31.73 ns |     1.74 ns |       195.2 ns |       198.4 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       279.3 ns |    130.44 ns |     7.15 ns |       271.1 ns |       284.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       464.5 ns |     11.74 ns |     0.64 ns |       464.1 ns |       465.3 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,553,906.2 ns** |  **1,514.46 ns** |    **83.01 ns** | **1,553,825.1 ns** | **1,553,991.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,701.9 ns | 49,176.00 ns | 2,695.50 ns |   612,049.2 ns |   617,438.3 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   657,644.1 ns | 49,272.26 ns | 2,700.78 ns |   654,620.6 ns |   659,817.7 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,381,155.7 ns | 35,666.33 ns | 1,954.99 ns | 1,378,930.6 ns | 1,382,597.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,005.7 ns | 23,077.83 ns | 1,264.97 ns |   160,619.4 ns |   163,097.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,137.3 ns | 17,247.91 ns |   945.42 ns |    90,258.9 ns |    92,137.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,105.6 ns |  5,182.27 ns |   284.06 ns |    64,778.0 ns |    65,284.6 ns |      - |      40 B |
