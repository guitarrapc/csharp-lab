```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,238.2 ns** |    **107.72 ns** |     **5.90 ns** |     **1,233.9 ns** |     **1,244.9 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,428.4 ns |     79.35 ns |     4.35 ns |     1,423.5 ns |     1,431.7 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,675.8 ns |    136.55 ns |     7.48 ns |     1,671.1 ns |     1,684.4 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,593.5 ns |    168.50 ns |     9.24 ns |     2,584.0 ns |     2,602.5 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       188.5 ns |     70.82 ns |     3.88 ns |       184.4 ns |       192.1 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       305.8 ns |     43.69 ns |     2.39 ns |       303.0 ns |       307.5 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       498.5 ns |    118.75 ns |     6.51 ns |       493.4 ns |       505.8 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,241.9 ns |    327.48 ns |    17.95 ns |     1,230.8 ns |     1,262.7 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,414.5 ns |    188.93 ns |    10.36 ns |     1,404.3 ns |     1,425.0 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,640.6 ns |    191.28 ns |    10.48 ns |     1,631.2 ns |     1,651.9 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,587.2 ns |    413.26 ns |    22.65 ns |     2,571.7 ns |     2,613.2 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       175.8 ns |      8.73 ns |     0.48 ns |       175.6 ns |       176.4 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       256.6 ns |     24.82 ns |     1.36 ns |       255.7 ns |       258.1 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       468.2 ns |     19.15 ns |     1.05 ns |       467.5 ns |       469.4 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,760.9 ns** |  **3,506.97 ns** |   **192.23 ns** | **1,553,620.6 ns** | **1,553,980.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,799.9 ns |  8,198.52 ns |   449.39 ns |   617,443.3 ns |   618,304.7 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,557.0 ns | 19,072.18 ns | 1,045.41 ns |   658,630.6 ns |   660,690.4 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,382,057.9 ns | 65,767.07 ns | 3,604.92 ns | 1,379,381.1 ns | 1,386,157.0 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,319.4 ns |  7,931.43 ns |   434.75 ns |   163,066.5 ns |   163,821.4 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,695.2 ns |  7,137.73 ns |   391.24 ns |    92,327.0 ns |    93,106.0 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,745.4 ns |  4,521.52 ns |   247.84 ns |    65,509.7 ns |    66,003.8 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,326.9 ns |  8,677.85 ns |   475.66 ns | 1,552,825.9 ns | 1,553,772.3 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,321.3 ns |  2,158.09 ns |   118.29 ns |   617,250.2 ns |   617,457.8 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,503.3 ns | 24,716.31 ns | 1,354.78 ns |   658,393.2 ns |   661,012.9 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,382,284.0 ns | 58,240.21 ns | 3,192.34 ns | 1,380,179.6 ns | 1,385,957.2 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   164,014.4 ns |  5,943.72 ns |   325.80 ns |   163,749.1 ns |   164,378.0 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,173.3 ns |  4,858.43 ns |   266.31 ns |    91,877.2 ns |    92,393.4 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,166.5 ns |  6,247.53 ns |   342.45 ns |    32,834.5 ns |    33,518.5 ns |      - |      40 B |
