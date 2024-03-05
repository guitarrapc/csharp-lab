```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,290.7 ns** |     **65.50 ns** |     **3.59 ns** |     **1,288.4 ns** |     **1,294.8 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,441.7 ns |     42.94 ns |     2.35 ns |     1,439.5 ns |     1,444.2 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,697.7 ns |    249.88 ns |    13.70 ns |     1,688.0 ns |     1,713.3 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,655.4 ns |    692.17 ns |    37.94 ns |     2,632.4 ns |     2,699.2 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       200.0 ns |     15.89 ns |     0.87 ns |       199.2 ns |       200.9 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       287.3 ns |      9.59 ns |     0.53 ns |       286.9 ns |       287.9 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       475.1 ns |     15.96 ns |     0.87 ns |       474.1 ns |       475.8 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,725.4 ns** | **18,451.66 ns** | **1,011.40 ns** | **1,545,134.9 ns** | **1,546,893.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,017.4 ns |  1,332.42 ns |    73.03 ns |   613,938.9 ns |   614,083.3 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,878.0 ns | 19,975.77 ns | 1,094.94 ns |   654,872.8 ns |   657,044.7 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,794.4 ns | 51,073.92 ns | 2,799.53 ns | 1,371,840.4 ns | 1,377,001.6 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,868.7 ns | 21,926.09 ns | 1,201.84 ns |   162,127.7 ns |   164,255.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,506.5 ns |  2,444.87 ns |   134.01 ns |    91,393.1 ns |    91,654.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,356.8 ns |  6,829.43 ns |   374.34 ns |    64,946.0 ns |    65,678.5 ns |      - |      40 B |
