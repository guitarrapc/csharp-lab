```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,306.4 ns** |     **36.74 ns** |     **2.01 ns** |     **1,304.1 ns** |     **1,308.1 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,457.8 ns |     85.49 ns |     4.69 ns |     1,452.4 ns |     1,461.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,700.9 ns |    138.14 ns |     7.57 ns |     1,693.4 ns |     1,708.5 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,646.7 ns |    293.88 ns |    16.11 ns |     2,633.2 ns |     2,664.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       199.3 ns |     12.88 ns |     0.71 ns |       198.4 ns |       199.7 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       284.7 ns |     22.55 ns |     1.24 ns |       283.8 ns |       286.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       488.5 ns |     41.22 ns |     2.26 ns |       486.0 ns |       490.4 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,364.3 ns** |  **3,482.58 ns** |   **190.89 ns** | **1,545,143.9 ns** | **1,545,477.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,247.7 ns |  2,065.62 ns |   113.22 ns |   614,146.5 ns |   614,370.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,970.3 ns | 17,499.15 ns |   959.19 ns |   654,863.3 ns |   656,554.4 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,710.9 ns | 47,863.15 ns | 2,623.54 ns | 1,372,102.4 ns | 1,376,738.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,222.9 ns |  1,196.70 ns |    65.59 ns |   162,165.3 ns |   162,294.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,412.6 ns |    464.20 ns |    25.44 ns |    91,383.6 ns |    91,431.1 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,615.2 ns |  5,983.72 ns |   327.99 ns |    65,296.4 ns |    65,951.7 ns |      - |      40 B |
