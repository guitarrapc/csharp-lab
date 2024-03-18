```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,312.5 ns** |       **9.89 ns** |     **0.54 ns** |     **1,311.9 ns** |     **1,312.9 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,470.3 ns |      68.49 ns |     3.75 ns |     1,467.7 ns |     1,474.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,718.8 ns |      69.90 ns |     3.83 ns |     1,714.4 ns |     1,721.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,690.0 ns |       6.88 ns |     0.38 ns |     2,689.7 ns |     2,690.4 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       206.2 ns |      18.09 ns |     0.99 ns |       205.0 ns |       206.9 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.6 ns |      41.24 ns |     2.26 ns |       284.2 ns |       288.6 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       496.2 ns |      54.54 ns |     2.99 ns |       493.7 ns |       499.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,871.7 ns** |  **15,152.27 ns** |   **830.55 ns** | **1,546,293.9 ns** | **1,547,823.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,426.3 ns |   2,270.39 ns |   124.45 ns |   614,291.9 ns |   614,537.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   661,307.2 ns | 167,947.47 ns | 9,205.77 ns |   655,505.9 ns |   671,921.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,733.6 ns |  22,417.99 ns | 1,228.81 ns | 1,372,356.6 ns | 1,374,718.7 ns |      - |     114 B |
| XxHash32Binary  | Byte[1048576]       |   162,283.3 ns |   2,148.12 ns |   117.75 ns |   162,201.1 ns |   162,418.2 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,570.4 ns |   3,086.82 ns |   169.20 ns |    91,375.9 ns |    91,682.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,240.4 ns |   3,496.55 ns |   191.66 ns |    65,033.8 ns |    65,412.3 ns |      - |      40 B |
