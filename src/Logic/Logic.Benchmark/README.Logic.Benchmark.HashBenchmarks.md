```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,322.7 ns** |     **57.20 ns** |     **3.14 ns** |     **1,319.9 ns** |     **1,326.1 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,452.2 ns |     12.44 ns |     0.68 ns |     1,451.5 ns |     1,452.9 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,734.8 ns |    616.19 ns |    33.78 ns |     1,696.9 ns |     1,761.7 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,663.9 ns |    250.13 ns |    13.71 ns |     2,650.5 ns |     2,677.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       201.2 ns |     23.42 ns |     1.28 ns |       200.1 ns |       202.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       292.9 ns |      8.26 ns |     0.45 ns |       292.4 ns |       293.2 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       482.6 ns |     11.38 ns |     0.62 ns |       482.0 ns |       483.3 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,774.8 ns** |  **2,260.29 ns** |   **123.89 ns** | **1,545,695.9 ns** | **1,545,917.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,361.4 ns |  2,822.29 ns |   154.70 ns |   614,182.9 ns |   614,457.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,319.9 ns | 23,549.32 ns | 1,290.82 ns |   655,299.1 ns |   657,770.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,965.3 ns | 16,943.32 ns |   928.72 ns | 1,372,404.4 ns | 1,374,037.3 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,271.4 ns |    213.04 ns |    11.68 ns |   162,264.6 ns |   162,284.8 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,449.6 ns |  1,132.47 ns |    62.07 ns |    91,381.0 ns |    91,501.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,588.3 ns |  8,645.42 ns |   473.88 ns |    65,271.7 ns |    66,133.2 ns |      - |      40 B |
