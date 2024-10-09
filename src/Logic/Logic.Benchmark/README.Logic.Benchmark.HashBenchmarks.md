```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,330.8 ns** |      **27.03 ns** |      **1.48 ns** |     **1,329.1 ns** |     **1,331.9 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,497.8 ns |      29.45 ns |      1.61 ns |     1,496.4 ns |     1,499.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,715.8 ns |      73.73 ns |      4.04 ns |     1,711.7 ns |     1,719.8 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,652.0 ns |     153.27 ns |      8.40 ns |     2,645.8 ns |     2,661.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       203.7 ns |       9.91 ns |      0.54 ns |       203.1 ns |       204.1 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       319.3 ns |       9.32 ns |      0.51 ns |       318.8 ns |       319.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       498.6 ns |      13.34 ns |      0.73 ns |       497.8 ns |       499.3 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,788.6 ns** |   **3,266.64 ns** |    **179.06 ns** | **1,545,610.7 ns** | **1,545,968.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   621,499.0 ns | 206,577.12 ns | 11,323.19 ns |   614,937.8 ns |   634,573.8 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   658,717.3 ns |  66,043.76 ns |  3,620.08 ns |   656,224.1 ns |   662,869.6 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,375,079.3 ns |   2,203.83 ns |    120.80 ns | 1,374,944.9 ns | 1,375,178.9 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,625.6 ns |   1,327.82 ns |     72.78 ns |   162,541.7 ns |   162,672.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,653.5 ns |   2,154.53 ns |    118.10 ns |    91,519.6 ns |    91,742.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,724.5 ns |   9,422.03 ns |    516.45 ns |    65,411.2 ns |    66,320.6 ns |      - |      40 B |
