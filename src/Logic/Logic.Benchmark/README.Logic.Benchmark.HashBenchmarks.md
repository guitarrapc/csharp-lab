```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,319.1 ns** |    **325.58 ns** |    **17.85 ns** |     **1,308.5 ns** |     **1,339.7 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,460.5 ns |     53.98 ns |     2.96 ns |     1,458.8 ns |     1,464.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,706.2 ns |     81.77 ns |     4.48 ns |     1,703.4 ns |     1,711.3 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,712.8 ns |    747.23 ns |    40.96 ns |     2,684.3 ns |     2,759.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       201.8 ns |     39.15 ns |     2.15 ns |       200.0 ns |       204.1 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       284.2 ns |      7.88 ns |     0.43 ns |       283.7 ns |       284.5 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       515.3 ns |     24.92 ns |     1.37 ns |       514.0 ns |       516.7 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,672.3 ns** |  **9,004.90 ns** |   **493.59 ns** | **1,545,306.5 ns** | **1,546,233.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,021.9 ns |  1,123.48 ns |    61.58 ns |   613,957.5 ns |   614,080.2 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,026.8 ns |  2,905.98 ns |   159.29 ns |   654,884.0 ns |   655,198.6 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,897.2 ns | 27,480.87 ns | 1,506.32 ns | 1,371,551.8 ns | 1,374,524.6 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,235.8 ns |    304.56 ns |    16.69 ns |   162,216.7 ns |   162,247.4 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,400.1 ns |  1,586.54 ns |    86.96 ns |    91,300.2 ns |    91,458.5 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,143.2 ns |  4,584.66 ns |   251.30 ns |    64,941.7 ns |    65,424.8 ns |      - |      40 B |
