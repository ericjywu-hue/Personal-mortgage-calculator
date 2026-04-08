<h1>個人抵押貸款計算器</h1>
<h3>專案簡介</h3>
以 C# WinForms 開發的個人房貸試算器，使用者可輸入房屋總價、自備款、貸款利率、貸款年限與寬限期，
即時計算並顯示每月應繳金額、首期利息、首期本金、總利息支出及總還款金額。<br>
<hr class="border-border-200 border-t-0.5 my-3 mx-1.5">
<h3>完成範例</h3>
<img width="1251" height="660" alt="image" src="https://github.com/user-attachments/assets/b73f3c7b-a26c-4b54-babc-f6393b676ffe" />
<hr class="border-border-200 border-t-0.5 my-3 mx-1.5">
<h3>功能特色</h3>
<li>支援自備款以「百分比 %」或「金額」兩種模式輸入</li>
<li>支援寬限期設定（前幾年僅繳利息）</li>
<li>所有輸出數值格式化為千分位 + 小數點後兩位</li>
<li>按 Enter 鍵可直接計算</li>
<li>按 Tab 鍵可在輸入欄位依序切換</li>
<li>非法輸入即時攔截，程式不會崩潰，範例:</li>
<img width="285" height="200" alt="image" src="https://github.com/user-attachments/assets/b7e5d38d-8237-414c-a140-aac3758dbf0b" />
<img width="285" height="200" alt="image" src="https://github.com/user-attachments/assets/276be1fa-6542-4578-a886-08a45e2db034" />
<img width="285" height="200" alt="image" src="https://github.com/user-attachments/assets/614a56df-ee63-4958-8d9f-1475953ebfd3" />
<hr class="border-border-200 border-t-0.5 my-3 mx-1.5">
<h3>使用說明</h3>
<div class="overflow-x-auto w-full px-2 mb-6">
  <table class="min-w-full border-collapse text-sm leading-[1.7] whitespace-normal">
    <thead class="text-left">
      <tr>
        <th scope="col" class="text-text-100 border-b-0.5 border-border-300/60 py-2 pr-4 align-top font-bold">輸入欄位</th>
        <th scope="col" class="text-text-100 border-b-0.5 border-border-300/60 py-2 pr-4 align-top font-bold">說明</th>
        <th scope="col" class="text-text-100 border-b-0.5 border-border-300/60 py-2 pr-4 align-top font-bold">範例</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td class="border-b-0.5 border-border-300/30 py-2 pr-4 align-top">房屋總價</td>
        <td class="border-b-0.5 border-border-300/30 py-2 pr-4 align-top">房屋購買總金額</td>
        <td class="border-b-0.5 border-border-300/30 py-2 pr-4 align-top">10000000</td>
      </tr>
      <tr>
        <td class="border-b-0.5 border-border-300/30 py-2 pr-4 align-top">自備款</td>
        <td class="border-b-0.5 border-border-300/30 py-2 pr-4 align-top">百分比模式單位是 %，不能大於 100，金額模式單位 $</td>
        <td class="border-b-0.5 border-border-300/30 py-2 pr-4 align-top">20</td>
      </tr>
      <tr>
        <td class="border-b-0.5 border-border-300/30 py-2 pr-4 align-top">貸款利率</td>
        <td class="border-b-0.5 border-border-300/30 py-2 pr-4 align-top">年利率（%）</td>
        <td class="border-b-0.5 border-border-300/30 py-2 pr-4 align-top">2.15</td></tr>
      <tr>
        <td class="border-b-0.5 border-border-300/30 py-2 pr-4 align-top">貸款年限</td>
        <td class="border-b-0.5 border-border-300/30 py-2 pr-4 align-top">還款總年數</td>
        <td class="border-b-0.5 border-border-300/30 py-2 pr-4 align-top">20</td>
      </tr>
      <tr>
        <td class="border-b-0.5 border-border-300/30 py-2 pr-4 align-top">寬限期</td>
        <td class="border-b-0.5 border-border-300/30 py-2 pr-4 align-top">前幾年只繳利息（選填，預設 0）</td>
        <td class="border-b-0.5 border-border-300/30 py-2 pr-4 align-top">2</td>
      </tr>
    </tbody>
  </table>
</div>
<hr class="border-border-200 border-t-0.5 my-3 mx-1.5">
<h3>計算公式</h3>
使用<b>本利均攤法</b>計算：<br>
<img width="285" height="88" alt="image" src="https://github.com/user-attachments/assets/d92fd927-4513-4a3b-b6eb-054c20a4bf92" />
<li>M：每月應繳金額</li>
<li>P：貸款本金</li>
<li>r：月利率（年利率÷12）</li>
<li>n：總期數（年限×12）</li><br>
<b>寬限期期間</b>：每月僅繳利息 =P×r，寬限期結束後再以剩餘期數重新計算等額還款金額。
