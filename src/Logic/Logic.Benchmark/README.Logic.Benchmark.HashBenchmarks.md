```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,239.7 ns** |      **59.26 ns** |      **3.25 ns** |     **1,237.5 ns** |     **1,243.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,377.5 ns |     109.68 ns |      6.01 ns |     1,370.6 ns |     1,381.4 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,606.6 ns |      21.09 ns |      1.16 ns |     1,605.6 ns |     1,607.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,605.2 ns |     143.65 ns |      7.87 ns |     2,596.2 ns |     2,611.0 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       210.8 ns |      39.73 ns |      2.18 ns |       209.2 ns |       213.3 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       297.6 ns |     116.82 ns |      6.40 ns |       293.2 ns |       305.0 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       482.8 ns |       2.74 ns |      0.15 ns |       482.7 ns |       482.9 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,049.5 ns** |   **4,965.32 ns** |    **272.17 ns** | **1,553,750.1 ns** | **1,554,282.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,973.7 ns |  11,628.91 ns |    637.42 ns |   617,488.4 ns |   618,695.6 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   665,391.0 ns | 211,479.70 ns | 11,591.92 ns |   658,668.5 ns |   678,776.2 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,395,356.8 ns | 125,185.78 ns |  6,861.86 ns | 1,387,655.2 ns | 1,400,819.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,118.1 ns |     966.47 ns |     52.98 ns |   163,057.0 ns |   163,150.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,204.1 ns |   3,124.11 ns |    171.24 ns |    92,010.3 ns |    92,335.1 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,820.6 ns |   2,945.09 ns |    161.43 ns |    65,641.3 ns |    65,954.5 ns |      - |      40 B |
