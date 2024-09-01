```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,324.1 ns** |     **125.23 ns** |      **6.86 ns** |     **1,316.7 ns** |     **1,330.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,541.2 ns |   1,045.58 ns |     57.31 ns |     1,480.2 ns |     1,593.9 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,705.7 ns |     134.55 ns |      7.38 ns |     1,699.6 ns |     1,713.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,708.4 ns |     817.96 ns |     44.84 ns |     2,671.3 ns |     2,758.2 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       258.6 ns |      20.10 ns |      1.10 ns |       257.8 ns |       259.9 ns | 0.0067 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       290.3 ns |       3.52 ns |      0.19 ns |       290.1 ns |       290.4 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       507.3 ns |     130.57 ns |      7.16 ns |       502.8 ns |       515.6 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,635.8 ns** |   **8,170.28 ns** |    **447.84 ns** | **1,545,269.8 ns** | **1,546,135.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,265.6 ns |   2,336.32 ns |    128.06 ns |   614,120.5 ns |   614,362.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   657,393.4 ns |  31,000.33 ns |  1,699.23 ns |   655,641.7 ns |   659,034.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,379,223.0 ns | 191,941.92 ns | 10,520.98 ns | 1,373,102.7 ns | 1,391,371.5 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   165,591.0 ns | 103,700.97 ns |  5,684.20 ns |   162,260.4 ns |   172,154.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,862.7 ns |  12,193.65 ns |    668.38 ns |    91,405.9 ns |    92,629.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,523.2 ns |   7,134.73 ns |    391.08 ns |    65,286.7 ns |    65,974.6 ns |      - |      40 B |
