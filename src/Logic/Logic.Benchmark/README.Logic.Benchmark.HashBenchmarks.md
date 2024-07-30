```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev    | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|----------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,325.2 ns** |    **137.77 ns** |   **7.55 ns** |     **1,318.6 ns** |     **1,333.5 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,487.7 ns |    295.80 ns |  16.21 ns |     1,477.4 ns |     1,506.4 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,724.9 ns |    278.18 ns |  15.25 ns |     1,709.4 ns |     1,739.8 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,665.1 ns |     67.50 ns |   3.70 ns |     2,661.7 ns |     2,669.0 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.7 ns |     29.52 ns |   1.62 ns |       200.9 ns |       204.1 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       300.0 ns |      0.12 ns |   0.01 ns |       300.0 ns |       300.0 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       498.6 ns |     33.48 ns |   1.84 ns |       496.8 ns |       500.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,331.0 ns** |  **4,160.51 ns** | **228.05 ns** | **1,545,118.9 ns** | **1,545,572.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,422.7 ns |  7,389.33 ns | 405.03 ns |   614,104.1 ns |   614,878.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,370.9 ns | 13,032.26 ns | 714.34 ns |   654,946.5 ns |   656,195.6 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,894.2 ns |  3,848.77 ns | 210.96 ns | 1,372,664.0 ns | 1,373,078.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,337.0 ns |    400.12 ns |  21.93 ns |   162,312.3 ns |   162,354.1 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,383.7 ns |    621.05 ns |  34.04 ns |    91,353.8 ns |    91,420.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,716.4 ns | 10,857.07 ns | 595.11 ns |    65,188.1 ns |    66,361.1 ns |      - |      40 B |
