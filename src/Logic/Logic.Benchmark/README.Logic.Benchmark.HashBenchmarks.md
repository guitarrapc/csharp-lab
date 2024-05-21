```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,326.5 ns** |     **122.05 ns** |      **6.69 ns** |     **1,319.5 ns** |     **1,332.8 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,474.1 ns |      44.45 ns |      2.44 ns |     1,471.6 ns |     1,476.5 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,717.1 ns |     384.75 ns |     21.09 ns |     1,703.4 ns |     1,741.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,696.4 ns |     196.50 ns |     10.77 ns |     2,690.1 ns |     2,708.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       204.4 ns |      12.90 ns |      0.71 ns |       203.6 ns |       204.9 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       287.0 ns |      15.45 ns |      0.85 ns |       286.2 ns |       287.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       501.9 ns |      54.23 ns |      2.97 ns |       498.6 ns |       504.4 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,822.4 ns** |   **5,398.95 ns** |    **295.93 ns** | **1,545,594.7 ns** | **1,546,156.9 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   613,885.8 ns |   2,497.04 ns |    136.87 ns |   613,737.6 ns |   614,007.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   654,576.1 ns |   1,149.88 ns |     63.03 ns |   654,523.4 ns |   654,645.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,384,874.4 ns | 335,612.40 ns | 18,396.05 ns | 1,374,198.1 ns | 1,406,116.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,304.9 ns |   4,240.68 ns |    232.45 ns |   162,143.5 ns |   162,571.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,573.0 ns |   3,252.26 ns |    178.27 ns |    91,460.4 ns |    91,778.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,335.0 ns |   7,111.95 ns |    389.83 ns |    64,934.6 ns |    65,713.3 ns |      - |      40 B |
