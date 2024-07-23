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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,314.5 ns** |     **126.77 ns** |      **6.95 ns** |     **1,308.3 ns** |     **1,322.0 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,470.5 ns |      52.65 ns |      2.89 ns |     1,468.7 ns |     1,473.8 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,739.0 ns |     129.53 ns |      7.10 ns |     1,731.1 ns |     1,744.8 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,665.3 ns |     167.23 ns |      9.17 ns |     2,656.2 ns |     2,674.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       244.6 ns |      49.06 ns |      2.69 ns |       241.5 ns |       246.2 ns | 0.0067 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       293.8 ns |      16.87 ns |      0.92 ns |       292.9 ns |       294.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       487.5 ns |      49.87 ns |      2.73 ns |       484.5 ns |       489.9 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,608.6 ns** |  **19,377.99 ns** |  **1,062.17 ns** | **1,545,673.7 ns** | **1,547,763.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,326.6 ns |   2,753.14 ns |    150.91 ns |   614,154.5 ns |   614,436.1 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,935.9 ns |  16,511.28 ns |    905.04 ns |   655,060.6 ns |   656,868.0 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,388,026.9 ns | 406,783.18 ns | 22,297.16 ns | 1,374,653.6 ns | 1,413,766.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,506.2 ns |  41,444.24 ns |  2,271.70 ns |   162,184.4 ns |   166,129.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,681.7 ns |   3,421.13 ns |    187.52 ns |    91,489.7 ns |    91,864.4 ns |      - |      34 B |
| XxHash128Binary | Byte[1048576]       |    64,924.8 ns |   1,395.86 ns |     76.51 ns |    64,845.4 ns |    64,998.1 ns |      - |      40 B |
