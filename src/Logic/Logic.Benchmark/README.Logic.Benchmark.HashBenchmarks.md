```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,312.7 ns** |    **124.39 ns** |     **6.82 ns** |     **1,306.6 ns** |     **1,320.0 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,452.2 ns |    102.72 ns |     5.63 ns |     1,447.8 ns |     1,458.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,692.2 ns |    131.24 ns |     7.19 ns |     1,684.9 ns |     1,699.3 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,630.7 ns |    178.39 ns |     9.78 ns |     2,620.0 ns |     2,639.0 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       188.0 ns |     13.25 ns |     0.73 ns |       187.2 ns |       188.5 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       272.6 ns |     17.47 ns |     0.96 ns |       272.0 ns |       273.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       511.3 ns |     32.44 ns |     1.78 ns |       510.3 ns |       513.4 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,140.0 ns** |  **2,871.28 ns** |   **157.38 ns** | **1,546,006.4 ns** | **1,546,313.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,647.3 ns |  2,065.58 ns |   113.22 ns |   614,571.1 ns |   614,777.4 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,376.1 ns |  4,894.75 ns |   268.30 ns |   655,151.3 ns |   655,673.1 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,375,561.2 ns | 65,044.06 ns | 3,565.28 ns | 1,372,370.6 ns | 1,379,409.6 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,446.3 ns |  4,785.32 ns |   262.30 ns |   162,279.8 ns |   162,748.7 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,893.9 ns |  7,178.41 ns |   393.47 ns |    91,567.2 ns |    92,330.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,659.8 ns |  4,679.81 ns |   256.52 ns |    33,490.8 ns |    33,955.0 ns |      - |      40 B |
