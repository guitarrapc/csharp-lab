```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,245.9 ns** |     **52.31 ns** |     **2.87 ns** |     **1,243.4 ns** |     **1,249.0 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,458.8 ns |    246.19 ns |    13.49 ns |     1,443.5 ns |     1,469.2 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,677.7 ns |    123.25 ns |     6.76 ns |     1,671.2 ns |     1,684.7 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,602.3 ns |    486.20 ns |    26.65 ns |     2,581.2 ns |     2,632.2 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       185.6 ns |     21.86 ns |     1.20 ns |       184.7 ns |       187.0 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       307.6 ns |     85.20 ns |     4.67 ns |       304.7 ns |       313.0 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       461.3 ns |     44.87 ns |     2.46 ns |       459.7 ns |       464.1 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,231.7 ns |     24.12 ns |     1.32 ns |     1,230.6 ns |     1,233.1 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,402.3 ns |     63.05 ns |     3.46 ns |     1,399.2 ns |     1,406.0 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,623.8 ns |     66.57 ns |     3.65 ns |     1,619.7 ns |     1,626.4 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,577.5 ns |    166.23 ns |     9.11 ns |     2,567.2 ns |     2,584.7 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       180.2 ns |     16.32 ns |     0.89 ns |       179.5 ns |       181.2 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       259.5 ns |     42.25 ns |     2.32 ns |       256.9 ns |       261.3 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       477.1 ns |     35.07 ns |     1.92 ns |       474.9 ns |       478.4 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,373.8 ns** |  **3,029.11 ns** |   **166.04 ns** | **1,553,201.0 ns** | **1,553,532.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,690.5 ns |  7,983.32 ns |   437.59 ns |   617,302.1 ns |   618,164.6 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   658,499.5 ns |  2,904.94 ns |   159.23 ns |   658,316.9 ns |   658,609.9 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,379,300.7 ns |  7,366.53 ns |   403.78 ns | 1,378,969.6 ns | 1,379,750.5 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,468.5 ns | 10,605.39 ns |   581.32 ns |   163,022.6 ns |   164,126.0 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,002.9 ns |  2,778.24 ns |   152.28 ns |    91,910.5 ns |    92,178.7 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,521.2 ns |  1,132.33 ns |    62.07 ns |    65,468.1 ns |    65,589.4 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,794.5 ns |  6,675.69 ns |   365.92 ns | 1,553,522.2 ns | 1,554,210.5 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,343.8 ns |  1,287.09 ns |    70.55 ns |   617,267.9 ns |   617,407.3 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,496.3 ns | 18,665.49 ns | 1,023.12 ns |   658,636.1 ns |   660,627.7 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,382,048.7 ns | 37,473.58 ns | 2,054.05 ns | 1,379,805.9 ns | 1,383,838.4 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,096.6 ns |  1,159.84 ns |    63.57 ns |   163,038.6 ns |   163,164.6 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,985.7 ns |  2,698.69 ns |   147.92 ns |    91,851.2 ns |    92,144.1 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,765.9 ns |  2,632.16 ns |   144.28 ns |    33,667.6 ns |    33,931.6 ns |      - |      40 B |
