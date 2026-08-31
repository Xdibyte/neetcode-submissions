class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        Map<String, Integer> groups = new HashMap<>();
        List<List<String>> output = new ArrayList<>();
        for(int i = 0; i < strs.length; i++)
        {
            int[] frequencies = new int[26];
            for(int j = 0; j < strs[i].length(); j++)
            {
                frequencies[(int)(strs[i].charAt(j) - 97)]++;
            }
            String key = Arrays.toString(frequencies);
            if(groups.containsKey(key))
            {
                output.get(groups.get(key)).add(strs[i]);
            }
            else
            {
                output.add(new ArrayList<>());
                output.get(output.size() - 1).add(strs[i]);
                groups.put(key, output.size() - 1);
            }
        }
        return output;
    }
}
