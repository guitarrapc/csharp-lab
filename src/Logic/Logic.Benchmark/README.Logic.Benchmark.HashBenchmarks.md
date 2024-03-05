```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,298.3 ns** |     **336.47 ns** |    **18.44 ns** |     **1,284.2 ns** |     **1,319.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,444.5 ns |      86.96 ns |     4.77 ns |     1,441.4 ns |     1,450.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,745.0 ns |     822.58 ns |    45.09 ns |     1,708.5 ns |     1,795.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,678.3 ns |     749.31 ns |    41.07 ns |     2,646.3 ns |     2,724.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.0 ns |      32.31 ns |     1.77 ns |       200.0 ns |       203.5 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       281.8 ns |      21.31 ns |     1.17 ns |       280.5 ns |       282.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       472.7 ns |      36.87 ns |     2.02 ns |       471.1 ns |       474.9 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,557,457.3 ns** | **181,248.39 ns** | **9,934.84 ns** | **1,546,031.6 ns** | **1,564,059.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   615,770.9 ns |  29,754.38 ns | 1,630.94 ns |   614,055.9 ns |   617,302.2 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   654,779.4 ns |   1,959.13 ns |   107.39 ns |   654,662.2 ns |   654,873.1 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,381,706.4 ns |  30,864.64 ns | 1,691.80 ns | 1,380,674.3 ns | 1,383,658.9 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,231.1 ns |   1,107.17 ns |    60.69 ns |   162,180.7 ns |   162,298.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,417.3 ns |   2,145.93 ns |   117.63 ns |    91,324.3 ns |    91,549.5 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,380.6 ns |   8,139.60 ns |   446.16 ns |    64,867.8 ns |    65,679.5 ns |      - |      40 B |
