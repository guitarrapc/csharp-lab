```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,315.2 ns** |     **23.08 ns** |     **1.27 ns** |     **1,313.8 ns** |     **1,316.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,476.6 ns |    130.44 ns |     7.15 ns |     1,470.6 ns |     1,484.5 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,714.7 ns |     45.51 ns |     2.49 ns |     1,712.5 ns |     1,717.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,691.5 ns |    240.86 ns |    13.20 ns |     2,677.0 ns |     2,702.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       211.2 ns |     29.10 ns |     1.60 ns |       209.8 ns |       213.0 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       285.7 ns |      2.15 ns |     0.12 ns |       285.6 ns |       285.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       489.6 ns |     13.40 ns |     0.73 ns |       488.7 ns |       490.1 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,540.4 ns** | **13,577.77 ns** |   **744.24 ns** | **1,545,910.7 ns** | **1,547,361.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,505.6 ns |  2,515.84 ns |   137.90 ns |   614,375.3 ns |   614,650.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,319.4 ns | 21,458.57 ns | 1,176.22 ns |   655,151.4 ns |   657,503.6 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,375,183.2 ns | 76,271.30 ns | 4,180.69 ns | 1,372,316.3 ns | 1,379,980.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,245.1 ns |  1,438.98 ns |    78.88 ns |   162,176.9 ns |   162,331.4 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,677.7 ns |    940.62 ns |    51.56 ns |    91,626.4 ns |    91,729.5 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,370.7 ns |  6,576.56 ns |   360.48 ns |    64,980.5 ns |    65,691.4 ns |      - |      40 B |
