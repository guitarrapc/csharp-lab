```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,314.0 ns** |      **99.41 ns** |      **5.45 ns** |     **1,309.6 ns** |     **1,320.1 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,479.7 ns |     435.90 ns |     23.89 ns |     1,465.5 ns |     1,507.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,723.1 ns |     109.08 ns |      5.98 ns |     1,716.3 ns |     1,727.1 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,657.1 ns |     319.55 ns |     17.52 ns |     2,645.6 ns |     2,677.2 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.1 ns |       4.06 ns |      0.22 ns |       201.9 ns |       202.3 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       288.7 ns |      24.21 ns |      1.33 ns |       287.3 ns |       289.9 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       503.8 ns |      76.44 ns |      4.19 ns |       501.2 ns |       508.7 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,376.7 ns** |   **6,745.17 ns** |    **369.73 ns** | **1,545,963.0 ns** | **1,546,675.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,272.8 ns |   5,009.61 ns |    274.59 ns |   613,995.9 ns |   614,545.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,210.2 ns |  19,956.45 ns |  1,093.88 ns |   655,160.1 ns |   657,343.2 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,383,028.4 ns | 286,660.30 ns | 15,712.82 ns | 1,373,559.5 ns | 1,401,166.1 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,748.2 ns |  16,545.36 ns |    906.91 ns |   162,176.9 ns |   163,793.9 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,415.7 ns |     367.11 ns |     20.12 ns |    91,394.0 ns |    91,433.8 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,087.3 ns |   2,261.97 ns |    123.99 ns |    65,006.6 ns |    65,230.0 ns |      - |      40 B |
