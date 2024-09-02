export function drawArray(dataList, ID) {
    const canvas = document.getElementById(ID);
    const ctx = canvas.getContext('2d');

    ctx.clearRect(0, 0, canvas.width, canvas.height);

    dataList.forEach((data) => {
        ctx.fillStyle = data.color;
        ctx.fillRect(data.x, data.y, 20, -data.value * 10);
        ctx.fillStyle = 'red';
        ctx.font = '8px Arial';
        ctx.fillText(data.value, data.x + 5, data.y + 10)
    });
}

export function processData(jsonData) {
    console.log("PROCESSING DATA");
    // Parse JSON data
    const data = JSON.parse(jsonData);

    // Assuming Data objects have a 'Value' and 'Coord' property
    const dataList = data.map(item => ({
        value: item.Value,
        x: item.Coord.X,
        y: item.Coord.Y,
        color: item.Color
    }));
    console.log(dataList);

    return dataList;
}