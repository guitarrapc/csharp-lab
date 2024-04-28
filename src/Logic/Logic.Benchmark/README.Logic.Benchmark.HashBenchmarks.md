```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,312.7 ns** |    **138.44 ns** |     **7.59 ns** |     **1,308.3 ns** |     **1,321.5 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,457.9 ns |     51.16 ns |     2.80 ns |     1,454.7 ns |     1,460.1 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,714.0 ns |    289.18 ns |    15.85 ns |     1,701.6 ns |     1,731.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,669.8 ns |    100.85 ns |     5.53 ns |     2,663.9 ns |     2,674.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.1 ns |     36.46 ns |     2.00 ns |       200.1 ns |       204.1 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       285.4 ns |      8.59 ns |     0.47 ns |       285.1 ns |       285.9 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       504.8 ns |    150.19 ns |     8.23 ns |       498.7 ns |       514.1 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,470.5 ns** |  **3,159.46 ns** |   **173.18 ns** | **1,545,273.9 ns** | **1,545,600.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,131.5 ns |    859.21 ns |    47.10 ns |   614,082.1 ns |   614,175.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,453.6 ns | 14,215.02 ns |   779.17 ns |   655,613.1 ns |   657,151.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,504.8 ns |  4,805.55 ns |   263.41 ns | 1,372,284.4 ns | 1,372,796.5 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,390.0 ns |  4,072.12 ns |   223.21 ns |   162,141.7 ns |   162,574.0 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,368.1 ns | 20,606.46 ns | 1,129.51 ns |    91,712.4 ns |    93,672.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,369.8 ns |  9,403.00 ns |   515.41 ns |    64,977.2 ns |    65,953.5 ns |      - |      40 B |
