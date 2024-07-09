```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,332.4 ns** |     **459.05 ns** |     **25.16 ns** |     **1,317.3 ns** |     **1,361.5 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,475.6 ns |     437.01 ns |     23.95 ns |     1,460.2 ns |     1,503.2 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,732.1 ns |     392.08 ns |     21.49 ns |     1,717.6 ns |     1,756.8 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,635.8 ns |     123.32 ns |      6.76 ns |     2,631.1 ns |     2,643.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       200.9 ns |      12.08 ns |      0.66 ns |       200.3 ns |       201.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       284.0 ns |       3.03 ns |      0.17 ns |       283.9 ns |       284.2 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       481.8 ns |      53.04 ns |      2.91 ns |       478.5 ns |       484.0 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,509.5 ns** |   **3,533.40 ns** |    **193.68 ns** | **1,545,310.9 ns** | **1,545,697.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,434.8 ns |   6,097.06 ns |    334.20 ns |   614,235.8 ns |   614,820.7 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,071.8 ns |   6,005.56 ns |    329.18 ns |   654,789.1 ns |   655,433.2 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,384,338.9 ns | 360,585.58 ns | 19,764.91 ns | 1,372,031.4 ns | 1,407,137.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,205.4 ns |   1,585.26 ns |     86.89 ns |   162,125.4 ns |   162,297.8 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,033.0 ns |   1,240.75 ns |     68.01 ns |    91,984.1 ns |    92,110.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,353.6 ns |  10,367.02 ns |    568.25 ns |    64,989.5 ns |    66,008.4 ns |      - |      40 B |
