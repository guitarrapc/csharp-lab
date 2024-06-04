```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,329.1 ns** |    **285.60 ns** |    **15.65 ns** |     **1,314.8 ns** |     **1,345.8 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,448.1 ns |     98.21 ns |     5.38 ns |     1,443.3 ns |     1,454.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,724.7 ns |    143.06 ns |     7.84 ns |     1,717.0 ns |     1,732.7 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,631.9 ns |    146.73 ns |     8.04 ns |     2,623.0 ns |     2,638.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       199.5 ns |     22.16 ns |     1.21 ns |       198.3 ns |       200.7 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       290.1 ns |      4.36 ns |     0.24 ns |       289.8 ns |       290.3 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       526.6 ns |    141.09 ns |     7.73 ns |       521.2 ns |       535.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,324.4 ns** |    **915.87 ns** |    **50.20 ns** | **1,545,294.3 ns** | **1,545,382.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,187.1 ns |  1,762.91 ns |    96.63 ns |   614,119.6 ns |   614,297.8 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,504.2 ns | 24,090.92 ns | 1,320.50 ns |   654,984.6 ns |   657,372.6 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,609.6 ns |  9,006.36 ns |   493.67 ns | 1,372,107.1 ns | 1,373,093.9 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,299.1 ns |  2,601.33 ns |   142.59 ns |   162,166.8 ns |   162,450.1 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,356.0 ns |  1,283.05 ns |    70.33 ns |    91,314.4 ns |    91,437.2 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,444.8 ns | 15,187.90 ns |   832.50 ns |    64,925.7 ns |    66,405.1 ns |      - |      40 B |
