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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,307.2 ns** |     **86.83 ns** |     **4.76 ns** |     **1,302.4 ns** |     **1,311.9 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,450.6 ns |    114.57 ns |     6.28 ns |     1,445.5 ns |     1,457.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,725.8 ns |    215.58 ns |    11.82 ns |     1,715.2 ns |     1,738.5 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,669.1 ns |  1,010.60 ns |    55.39 ns |     2,636.4 ns |     2,733.1 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       200.0 ns |     31.77 ns |     1.74 ns |       199.0 ns |       202.0 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       281.6 ns |     15.60 ns |     0.85 ns |       280.6 ns |       282.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       509.7 ns |     85.93 ns |     4.71 ns |       506.0 ns |       515.0 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,638.2 ns** |    **857.95 ns** |    **47.03 ns** | **1,545,604.3 ns** | **1,545,691.9 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,403.6 ns |  3,073.53 ns |   168.47 ns |   614,229.5 ns |   614,565.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,309.5 ns | 12,332.37 ns |   675.98 ns |   655,576.0 ns |   656,907.3 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,566.2 ns | 39,540.11 ns | 2,167.33 ns | 1,371,942.9 ns | 1,376,027.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,284.6 ns |    795.19 ns |    43.59 ns |   162,240.2 ns |   162,327.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    93,806.3 ns | 69,362.34 ns | 3,801.98 ns |    91,498.1 ns |    98,194.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,470.8 ns |  6,187.75 ns |   339.17 ns |    65,079.4 ns |    65,676.8 ns |      - |      40 B |
