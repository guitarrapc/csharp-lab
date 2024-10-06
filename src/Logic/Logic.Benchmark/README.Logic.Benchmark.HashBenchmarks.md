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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,213.6 ns** |     **41.48 ns** |     **2.27 ns** |     **1,211.7 ns** |     **1,216.1 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,376.9 ns |     91.82 ns |     5.03 ns |     1,371.9 ns |     1,382.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,625.4 ns |     42.95 ns |     2.35 ns |     1,623.0 ns |     1,627.7 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,575.6 ns |    239.65 ns |    13.14 ns |     2,566.2 ns |     2,590.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.1 ns |     27.64 ns |     1.52 ns |       200.4 ns |       203.3 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       288.9 ns |     58.24 ns |     3.19 ns |       285.7 ns |       292.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       514.6 ns |     37.66 ns |     2.06 ns |       513.1 ns |       517.0 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,081.6 ns** |  **9,514.65 ns** |   **521.53 ns** | **1,553,742.1 ns** | **1,554,682.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,516.8 ns |  2,668.56 ns |   146.27 ns |   617,360.9 ns |   617,651.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   658,472.2 ns |  4,557.79 ns |   249.83 ns |   658,254.8 ns |   658,745.1 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,382,340.9 ns | 77,712.74 ns | 4,259.70 ns | 1,379,803.2 ns | 1,387,258.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,233.8 ns |  2,734.90 ns |   149.91 ns |   163,066.0 ns |   163,354.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,915.2 ns |    652.83 ns |    35.78 ns |    91,882.0 ns |    91,953.1 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    66,183.8 ns | 10,127.36 ns |   555.11 ns |    65,570.9 ns |    66,652.8 ns |      - |      40 B |
