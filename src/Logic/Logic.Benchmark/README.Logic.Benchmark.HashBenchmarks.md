```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error       | StdDev    | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|------------:|----------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,337.2 ns** |    **42.71 ns** |   **2.34 ns** |     **1,334.6 ns** |     **1,339.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,477.3 ns |    62.21 ns |   3.41 ns |     1,473.3 ns |     1,479.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,711.4 ns |    55.40 ns |   3.04 ns |     1,708.1 ns |     1,714.1 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,692.2 ns |   209.51 ns |  11.48 ns |     2,681.3 ns |     2,704.2 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       205.1 ns |    86.32 ns |   4.73 ns |       202.2 ns |       210.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       290.6 ns |    30.88 ns |   1.69 ns |       289.6 ns |       292.6 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       483.4 ns |    58.45 ns |   3.20 ns |       479.7 ns |       485.4 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,681.9 ns** | **1,658.65 ns** |  **90.92 ns** | **1,545,579.0 ns** | **1,545,751.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,292.9 ns | 2,506.22 ns | 137.37 ns |   614,191.5 ns |   614,449.3 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,206.1 ns | 3,844.94 ns | 210.75 ns |   654,966.7 ns |   655,363.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,312.4 ns | 7,374.43 ns | 404.22 ns | 1,371,846.7 ns | 1,372,573.3 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,383.1 ns | 1,813.71 ns |  99.42 ns |   162,298.2 ns |   162,492.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,476.6 ns | 1,113.47 ns |  61.03 ns |    91,407.5 ns |    91,523.3 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,560.3 ns | 6,489.19 ns | 355.69 ns |    65,302.1 ns |    65,966.0 ns |      - |      40 B |
